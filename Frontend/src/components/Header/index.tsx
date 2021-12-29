import React from "react";
import Image from "next/image";

interface HeaderProps {
  user: string;
}

const Header = ({ user }: HeaderProps) => {
  return (
    <div className="container flex flex-row mx-auto my-12 justify-between items-center">
      <Image
        src={"/assets/logo.png"}
        height={83.42}
        layout="fixed"
        width={363.74}
        priority
      />
      {user}
    </div>
  );
};

export default Header;
