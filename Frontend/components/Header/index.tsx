import React from "react";
import Image from "next/image";
import Logo from "../../public/assets/logo.png";

interface HeaderProps {
  user: string;
}

const Header = ({ user }: HeaderProps) => {
  return (
    <div className="flex flex-row mx-4 my-12 justify-between items-center">
      <Image src={Logo} height={83.42} layout="fixed" width={363.74} />
      {user}
    </div>
  );
};

export default Header;
