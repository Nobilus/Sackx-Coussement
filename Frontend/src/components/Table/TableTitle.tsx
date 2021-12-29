import classNames from "classnames/bind";
import { FunctionComponent, useState } from "react";

interface TableTitleProps {
  titles: Array<string>;
  colAmount?: number;
}

const TableTitle: FunctionComponent<TableTitleProps> = ({
  titles,
  colAmount,
}) => {
  const [cols] = useState(colAmount ? colAmount : titles.length);

  return (
    <div
      className={classNames("grid mx-2 mt-4 mb-2 place-items-center", [
        `grid-cols-${cols}`,
      ])}
    >
      {titles.map((title, i) => (
        <p
          key={`table-title-${i}`}
          className={classNames(
            "font-title text-green-25 text-md",
            {
              "place-self-start": i === 0,
            },
            { "place-self-end": i === titles.length - 1 }
          )}
        >
          {title}
        </p>
      ))}
    </div>
  );
};

export default TableTitle;
