const TITLE = "Radium Launcher"

/**
 * Obtenir une string qui sert d'affichage pour le menu de navigation
 * @returns str (string d'affichage des pages de navigation)
 */
function displayPage()
{
    return pages.map(page => `
    <li class="nav-item">
        <a class="nav-link ${page.disabled ? 'disabled' : 'active'}" aria-disabled=${page.disabled} href=${page.url}>${page.title}</a>
    </li>
    `).join('')
}

const page = {
    title : "Requirement",
    url : "pages/Requirement.html",
    disabled : true,
}

const page2 = {
    title : "About",
    url : "pages/About.html",
    disabled : true,
}

const page3 = {
    title : "Download",
    url : "pages/Requirement.html",
    disabled : true
}

let pages = [page, page2, page3];
let nav = document.getElementById('navbar');

nav.innerHTML = `
  <div class="container-fluid">
    <a class="navbar-brand" href="#">${TITLE}</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        ${displayPage()}
      </ul>
    </div>
  </div>
`