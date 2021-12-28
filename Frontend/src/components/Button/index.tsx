import { FunctionComponent } from "react";

interface ButtonProps extends React.ButtonHTMLAttributes<HTMLButtonElement> {
  children: React.ReactNode;
  btnType: "primary" | "secondary";
}

const Button: FunctionComponent<ButtonProps> = ({
  children,
  className = "",
  btnType,
  ...props
}) => {
  if (btnType === "primary") {
    return (
      <button
        className={`text-white bg-green-100 hover:bg-green-500 px-4 py-2 rounded mx-auto ${className}`}
        {...props}
      >
        {children}
      </button>
    );
  } else {
    return (
      <button
        className={`rounded border border-green bg-green px-4 py-2 text-white ml-8 ${className}`}
        {...props}
      >
        {children}
      </button>
    );
  }
};

export default Button;
