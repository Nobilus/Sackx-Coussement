import React, { useState } from "react";
import FormItem from "src/classes/FormItem";
import Button from "src/components/Button";
import Form from "src/components/Form";
import Card from "../components/Card";

function Login() {
  const [submitting, setSubmitting] = useState(false);

  const formItems = [
    new FormItem({
      type: "text",
      name: "username",
      id: "username",
      placeholder: "Gebruikersnaam",
      autoComplete: "username",
    }),
    new FormItem({
      type: "text",
      name: "password",
      id: "password",
      placeholder: "Wachtwoord",
      autoComplete: "current-password",
    }),
  ];

  const handleSubmit = () => {};

  return (
    <section className="flex h-screen flex-col justify-center items-center">
      <img src={"/assets/logo.png"} alt="Logo" className="mx-auto h-12" />
      <Card>
        <Form
          formItems={formItems}
          submitting={submitting}
          setSubmitting={setSubmitting}
          onSubmit={handleSubmit}
        />
        <Button type="submit" onSubmit={() => setSubmitting(true)}>
          Login
        </Button>
      </Card>
    </section>
  );
}

export default Login;
