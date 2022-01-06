const toLocaleCurrency = (number: number) => {
  return `€${number.toLocaleString("be-NL", { minimumFractionDigits: 2 })}`;
};

export default toLocaleCurrency;
