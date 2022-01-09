export default (dateString: string) => {
  return new Date(dateString).toISOString().split("T")[0];
};
