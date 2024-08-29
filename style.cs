h1 {
color : black;
font-size : 20px;
font-family : arial;
background-color : pink;
}
div {
  border : 2px black;
  border-radius : 5px;
  padding : 30px;

}

h2 {
  color : black
  font-size : 20px;
  font-family : arial;
  background-color : white;
}
@media (max-width: 960px) {
  /* Pour un écran < 960px, cette classe CSS s'applique */
  .container {
    width: 700px;
  }
}

@media (max-width: 720px) {
  /* Pour un écran < 720px, cette classe CSS s'applique */
  .container {
    width: 500px;
  }
}

@media (max-width: 540px) {
  /* Pour un écran < 540px, cette classe CSS s'applique */
  .container {
    width: 300px;
  }
}
