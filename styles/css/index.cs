/* Error: Can't find stylesheet to import.
 *    ,
 * 39 | @import "./css/variables.scss";
 *    |         ^^^^^^^^^^^^^^^^^^^^^^
 *    '
 *   styles\scss\variables.scss 39:9  @import
 *   styles\scss\index.scss 1:9       root stylesheet */

body::before {
  font-family: "Source Code Pro", "SF Mono", Monaco, Inconsolata, "Fira Mono",
      "Droid Sans Mono", monospace, monospace;
  white-space: pre;
  display: block;
  padding: 1em;
  margin-bottom: 1em;
  border-bottom: 2px solid black;
  content: "Error: Can't find stylesheet to import.\a    \2577 \a 39 \2502  @import \"./css/variables.scss\";\d\a    \2502          ^^^^^^^^^^^^^^^^^^^^^^\a    \2575 \a   styles\\scss\\variables.scss 39:9  @import\a   styles\\scss\\index.scss 1:9       root stylesheet";
}
