import { FunctionComponent } from "react";

interface TableTitleProps {
  titles: Array<string>;
}

const TableTitle: FunctionComponent<TableTitleProps> = ({ titles }) => {
  return (
    <div className="grid grid-cols-5 mx-2 mt-4 mb-2">
      {titles.map((title, i) => (
        <p
          key={`table-title-${i}`}
          className="font-title text-green-25 text-md"
        >
          {title}
        </p>
      ))}
    </div>
  );
};

export default TableTitle;
