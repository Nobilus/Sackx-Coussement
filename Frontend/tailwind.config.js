const defaultTheme = require("tailwindcss/defaultTheme");

module.exports = {
  mode: "jit",
  purge: ["./pages/**/*.{js,ts,jsx,tsx}", "./components/**/*.{js,ts,jsx,tsx}"],
  darkMode: false, // or 'media' or 'class'
  theme: {
    backgroundColor: (theme) => ({
      ...theme("colors"),
      primary: "#FAFCFA",
    }),
    textColor: (theme) => ({
      ...theme("colors"),
      primary: "#00371C",
    }),

    extend: {
      fontFamily: {
        body: ["Open Sans", ...defaultTheme.fontFamily.sans],
        title: ["Poppins", ...defaultTheme.fontFamily.sans],
      },
    },
  },
  variants: {
    extend: {},
  },
  plugins: [],
};
