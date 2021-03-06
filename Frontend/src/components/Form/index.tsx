import {
  FormEvent,
  FunctionComponent,
  useCallback,
  useEffect,
  useState,
} from "react";
import classNames from "classnames/bind";
import FormItem, { FormItemOption } from "src/classes/FormItem";
import dynamic from "next/dynamic";
import Button from "../Button";

// const Dropdown = dynamic(() => import("../dropdown"));
const Input = dynamic(() => import("src/components/Input/TextInput"));
// const DateInput = dynamic(() => import("../input/DateInput"));
// const TextArea = dynamic(() => import("../input/TextArea"));

interface FormProps {
  formItems: Array<FormItem>;
  rows?: number;
  cols?: number;
  rowGap?: number;
  colGap?: number;
  submitting?: boolean;
  setSubmitting?: React.Dispatch<React.SetStateAction<boolean>>;
  onItemChange?: any;
  onSubmit?: any;
  className?: string;
  externalError?: string;
  changed?: boolean;
}

const findIndexByName = (arr: FormItem[], searchName: string) => {
  return arr.findIndex(({ name }) => name === searchName);
};

const Form: FunctionComponent<FormProps> = ({
  formItems,
  cols = 1,
  rows,
  rowGap = 4,
  colGap = 2,
  onSubmit,
  submitting,
  setSubmitting,
  onItemChange,
  className = "",
  externalError,
  changed = false,
}) => {
  const [items, setItems] = useState<Array<FormItem>>(formItems);
  const [valuesHaveChanged, setValuesHaveChanged] = useState(changed);
  const onFormItemChange = useCallback(
    (e: FormEvent<HTMLInputElement>) => {
      const index = findIndexByName(items, e.currentTarget.name);

      if (index > -1) {
        const newItems = [
          ...items.slice(0, index),
          new FormItem({ ...items[index], value: e.currentTarget.value }),
          ...items.slice(index + 1),
        ];
        if (onItemChange) onItemChange(newItems[index]);

        setItems(newItems);
      }
    },
    [items]
  );

  const handleDropdownChange = useCallback(
    (e: FormItemOption | Array<FormItemOption>, name: string) => {
      const index = findIndexByName(items, name);
      if (index > -1) {
        if (Array.isArray(e)) {
          const ids = e.map((i) => i.id);
          const newItems = [
            ...items.slice(0, index),
            new FormItem({ ...items[index], value: ids }),
            ...items.slice(index + 1),
          ];
          console.log(newItems[index]);

          if (onItemChange) onItemChange(newItems[index]);
          setItems(newItems);
        } else {
          const newItems = [
            ...items.slice(0, index),
            new FormItem({ ...items[index], value: e.id }),
            ...items.slice(index + 1),
          ];
          if (onItemChange) onItemChange(newItems[index]);
          setItems(newItems);
        }
      }
    },
    [items]
  );

  const handleDateChange = useCallback(
    (d: Date, index: number) => {
      const newItems = [
        ...items.slice(0, index),
        new FormItem({ ...items[index], value: d }),
        ...items.slice(index + 1),
      ];
      if (onItemChange) {
        onItemChange(newItems[index]);
      }
      setItems(newItems);
    },
    [items]
  );

  const handleTextAreaChange = useCallback(
    (e: FormEvent<HTMLTextAreaElement>) => {
      const index = findIndexByName(items, e.currentTarget.name);

      if (index > -1) {
        const newItems = [
          ...items.slice(0, index),
          new FormItem({ ...items[index], value: e.currentTarget.value }),
          ...items.slice(index + 1),
        ];
        if (onItemChange) onItemChange(newItems[index]);

        setItems(newItems);
      }
    },
    [items]
  );

  function isEmpty(formItem: FormItem, index: number) {
    if (formItem.required) {
      if (formItem.value) {
        return !(formItem.value.toString().trim().length > 0);
      } else {
        return true;
      }
    }
    return false;
  }

  function isValidEmail(fi: FormItem) {
    const re = /\S+@\S+\.\S+/;
    return re.test(fi.value);
  }

  function formHasErrors(formItems: Array<FormItem>) {
    let counter = 0;
    let password = "";
    const newItems = formItems.map((item, index) => {
      if (isEmpty(item, index)) {
        item.faulty = "true";
        item.errormessage = "Verplicht!";
        counter++;
        return item;
      } else if (
        item.type === "email" &&
        !isValidEmail(item) &&
        item.required
      ) {
        counter++;
        item.faulty = "true";
        item.errormessage = "Geen geldig e-mail";
        return item;
      } else if (item.id === "password") {
        password = item.value;
      } else if (item.id === "repeatpassword" && password !== item.value) {
        item.faulty = "true";
        item.errormessage = "Wachtwoorden komen niet overeen";
        item.value = "";
        counter++;
        return item;
      }
      item.faulty = "false";
      item.errormessage = undefined;
      return item;
    });

    setItems(newItems);

    if (counter > 0) {
      return true;
    }
    return false;
  }

  function dynamicRowCols(amount: number | undefined, type: "rows" | "cols") {
    return `grid-${type}-${amount}`;
  }

  function dynamicGaps(amount: number | undefined, type: "x" | "y") {
    return `gap-${type}-${amount}`;
  }

  const handleEnterKeyPress = useCallback(
    (e: React.KeyboardEvent<HTMLFormElement>) => {
      const target = e.target as HTMLElement;
      if (e.key === "Enter" && target.tagName !== "TEXTAREA") {
        if (setSubmitting) setSubmitting(true);
      }
    },
    []
  );

  function handleButtonClick(e: any) {
    e.preventDefault;
  }

  useEffect(() => {
    function handleSubmit() {
      if (formHasErrors(items)) {
        console.log("form has errors");
      } else {
        onSubmit(items);
      }
      if (setSubmitting) setSubmitting(false);
    }
    if (submitting) {
      handleSubmit();
    }
  }, [submitting]);

  const formStyling = classNames(
    "grid items-end",
    { [dynamicGaps(colGap, "x")]: colGap },
    { [dynamicGaps(rowGap, "y")]: rowGap },
    { [dynamicRowCols(cols, "cols")]: cols },
    { [dynamicRowCols(rows, "rows")]: rows },
    className
  );

  return (
    <form className={formStyling} noValidate onKeyPress={handleEnterKeyPress}>
      {items.map(({ value, className, ...item }, index) => {
        // if (item.type === "date") {
        //   return (
        //     <DateInput
        //       key={`dateinput-${index}`}
        //       onChange={(d: Date) => handleDateChange(d, index)}
        //       value={items[index].value}
        //       className={className}
        //       selected={items[index].value}
        //       {...item}
        //     />
        //   );
        // } else if (
        //   item.type === "dropdown" ||
        //   item.type === "dropdown-multi-select"
        // ) {
        //   return (
        //     <Dropdown
        //       className={className}
        //       key={`dropdown-${index}`}
        //       options={
        //         item.options ?? [{ id: "", name: "option array required" }]
        //       }
        //       onChange={handleDropdownChange}
        //       placeholder={item.placeholder ?? "Placeholder is required"}
        //       name={item.name ?? "name is required"}
        //       multiSelect={item.type === "dropdown-multi-select"}
        //     />
        //   );
        // } else if (item.type === "text-area") {
        //   return (
        //     <TextArea
        //       key={`textarea-${index}`}
        //       onChange={handleTextAreaChange}
        //       value={items[index].value}
        //       errormessage={item.errormessage}
        //       faulty={items[index].faulty}
        //       className={className}
        //       {...item}
        //     />
        //   );
        // } else {
        if (item.type === "button") {
          return (
            <Button
              type={"button"}
              btntype={item.btntype}
              onClick={item.onClick}
              key={`btn-${index}`}
              className={classNames(className, item.btnClassName)}
            >
              {item.text}
            </Button>
          );
        } else {
          return (
            <Input
              key={`input-${index}`}
              onChange={onFormItemChange}
              value={items[index].value}
              errormessage={item.errormessage}
              faulty={items[index].faulty}
              className={className}
              inputClassName={item.inputClassName}
              {...item}
            />
          );
        }

        // }
      })}
    </form>
  );
};

export default Form;
