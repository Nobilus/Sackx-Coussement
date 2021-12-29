import React, { useState } from "react";
import FormItem from "src/classes/FormItem";
import Button from "src/components/Button";
import Form from "src/components/Form";
import { useAuth } from "src/providers/AuthProvider";
import Card from "../components/Card";

function Login() {
  const [submitting, setSubmitting] = useState(false);
  const { signIn } = useAuth();

  const formItems = [
    new FormItem({
      type: "text",
      name: "username",
      id: "username",
      placeholder: "Gebruikersnaam",
      autoComplete: "username",
    }),
    new FormItem({
      name: "password",
      id: "password",
      placeholder: "Wachtwoord",
      type: "password",
      autoComplete: "current-password",
    }),
  ];

  const handleSubmit = (e: any) => {
    console.log("click");

    console.log(e);

    signIn();
  };

  return (
    <section className="flex h-screen flex-col justify-center align-middle">
      <img src={"/assets/logo.png"} alt="Logo" className="mx-auto h-12" />
      <Card className="flex flex-col justify-center align-middle mx-auto">
        <Form
          formItems={formItems}
          submitting={submitting}
          setSubmitting={setSubmitting}
          onSubmit={handleSubmit}
        />
        <Button
          btntype="primary"
          type="submit"
          onClick={() => setSubmitting(true)}
          className=" w-44"
        >
          Login
        </Button>
      </Card>
    </section>
  );
}

export default Login;
