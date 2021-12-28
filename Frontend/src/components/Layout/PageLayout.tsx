import { FunctionComponent } from "react";

const PageLayout: FunctionComponent = ({ children }) => {
  return <div className="bg-gray-100 max-w-6xl mx-auto pb-16">{children}</div>;
};

export default PageLayout;
