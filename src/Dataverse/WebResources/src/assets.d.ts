/* Lets TypeScript accept `import "./styles.css"` and imports of images.
   build.mjs is what actually embeds them in the page. */

declare module "*.css";

declare module "*.png" {
  const url: string;
  export default url;
}
declare module "*.jpg" {
  const url: string;
  export default url;
}
declare module "*.svg" {
  const url: string;
  export default url;
}
