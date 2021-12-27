export default (number: number) => {
  return `€${number.toLocaleString("be-NL", { minimumFractionDigits: 2 })}`;
};
