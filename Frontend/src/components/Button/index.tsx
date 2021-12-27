import { FunctionComponent } from "react";

interface ButtonProps extends React.ButtonHTMLAttributes<HTMLButtonElement> {
  children: React.ReactNode;
}

const Button: FunctionComponent<ButtonProps> = ({
  children,
  className = "",
  ...props
}) => {
  return (
    <button
      className={`text-white bg-green-100 hover:bg-green-500 px-4 py-2 rounded mx-auto ${className}`}
      {...props}
    >
      {children}
    </button>
  );
};

export default Button;
