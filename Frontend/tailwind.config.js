const defaultTheme = require("tailwindcss/defaultTheme");

module.exports = {
  mode: "jit",
  content: [
    "src/pages/**/*.{js,ts,jsx,tsx}",
    "src/components/**/*.{js,ts,jsx,tsx}",
  ],
  safelist: [
    "grid-cols-1",
    "grid-cols-2",
    "grid-cols-3",
    "grid-cols-4",
    "grid-cols-5",
    "grid-cols-6",
  ],
  darkMode: "media", // or 'media' or 'class'
  theme: {
    extend: {
      colors: {
        black: "#000",
        white: "#FFF",
        green: {
          25: "#668776",
          50: "#00371C99",
          DEFAULT: "#0F844B",
          100: "#0F844B",
          200: "#00371C",
        },
        gray: {
          DEFAULT: "#FAFCFA",
          100: "#FAFCFA",
          200: "#00000029",
        },
      },
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
