import React, { FunctionComponent } from "react";
import { GiWoodPile } from "react-icons/gi";
import { IoDocumentTextOutline } from "react-icons/io5";
import { IoPeopleOutline } from "react-icons/io5";

import Link from "next/link";
import { useRouter } from "next/router";

interface LinkItemProps {
  href: string;
  title: string;
  icon: JSX.Element;
}

const LinkItem: FunctionComponent<LinkItemProps> = ({ href, icon, title }) => {
  return (
    <Link href={href}>
      <a className="flex flex-col items-center mx-auto mt-auto text-xs ">
        {icon}
        <p className="m-auto">{title}</p>
      </a>
    </Link>
  );
};

const Footer: FunctionComponent = () => {
  const { pathname } = useRouter();

  function isActive(routename: string) {
    if (pathname !== routename) {
      return false;
    } else {
      return true;
    }
  }

  const linkItems: Array<LinkItemProps> = [
    {
      href: "/",
      icon: (
        <GiWoodPile fill={isActive("/") ? "#00371C" : "#668776"} size={32} />
      ),
      title: "Producten",
    },
    {
      href: "/bestelbonnen",
      icon: (
        <IoDocumentTextOutline
          color={isActive("/bestelbonnen") ? "#00371C" : "#668776"}
          size={32}
        />
      ),
      title: "Bestelbonnen",
    },
    {
      href: "/klanten",
      icon: (
        <IoPeopleOutline
          color={isActive("/klanten") ? "#00371C" : "#668776"}
          size={32}
        />
      ),
      title: "Klanten",
    },
  ];

  return (
    <footer className="fixed float-left bottom-0 left-0 w-full bg-white flex flex-row justify-center items-center py-2 shadow-2xl">
      <div className="grid grid-cols-3 place-items-center max-w-3xl w-full">
        {linkItems.map((item, index) => (
          <LinkItem key={`linkitem-${index}`} {...item} />
        ))}
      </div>
    </footer>
  );
};

export default Footer;
