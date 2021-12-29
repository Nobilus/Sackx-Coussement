import classNames from "classnames/bind";
import { FunctionComponent } from "react";

interface PHContainerProps {
  className?: string;
}

const PageHeaderContainer: FunctionComponent<PHContainerProps> = ({
  children,
  className,
}) => {
  return (
    <div
      className={classNames(
        "container flex flex-row justify-between mx-auto mb-16",
        className
      )}
    >
      {children}
    </div>
  );
};

export default PageHeaderContainer;
