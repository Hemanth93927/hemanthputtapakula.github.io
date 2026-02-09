body {
  margin: 0;
  font-family: Arial, sans-serif;
  background: #111;
  color: white;
}

/* MENU */
.menu-btn {
  position: fixed;
  top: 15px;
  right: 20px;
  font-size: 28px;
  cursor: pointer;
  z-index: 1000;
}

nav {
  position: fixed;
  top: 0;
  right: -200px;
  width: 200px;
  height: 100%;
  background: #000;
  padding-top: 60px;
  transition: 0.3s;
}

nav a {
  display: block;
  color: white;
  padding: 15px;
  text-decoration: none;
}

nav a:hover {
  background: #333;
}

/* SECTIONS */
.section {
  padding: 60px 20px;
}

.home {
  text-align: center;
}

.profile-pic {
  width: 140px;
  height: 140px;
  border-radius: 50%;
  object-fit: cover;
}

/* BIODATA TABLE */
.biodata {
  width: 100%;
  max-width: 500px;
  margin: auto;
  border-collapse: collapse;
}

.biodata td {
  border: 1px solid #555;
  padding: 10px;
}

footer {
  text-align: center;
  padding: 15px;
  background: black;
}
