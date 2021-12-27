import { FunctionComponent } from "react";

interface CardProps {
  className?: string;
}

const Card: FunctionComponent<CardProps> = ({ children, className }) => {
  return (
    <div className={`bg-white m-5 rounded shadow-sm py-14 px-10 ${className}`}>
      {children}
    </div>
  );
};

export default Card;
