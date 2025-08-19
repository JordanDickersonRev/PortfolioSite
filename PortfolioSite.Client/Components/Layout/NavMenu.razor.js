export function getTheme() {
    let preferredTheme = localStorage.getItem("JordanDPortfolioSiteTheme");
    
    if (preferredTheme) {
        document.documentElement.style.colorScheme = preferredTheme;
    }
    else {
        preferredTheme = "light dark";
    }

    return preferredTheme;
}

export function setTheme(preferredTheme) {

    if (preferredTheme !== "dark" && preferredTheme !== "light") {
        preferredTheme = "light dark";
    }

    try {
        localStorage.setItem("JordanDPortfolioSiteTheme", preferredTheme);
        document.documentElement.style.colorScheme = preferredTheme;
    }
    catch (error) {
        preferredTheme = "light dark";

        let dialog = document.createElement("dialog");
        let dialogHeader = document.createElement("div");
        let h5 = document.createElement("h5");
        let dialogContent = document.createElement("div");
        let p = document.createElement("p");
        let dialogFooter = document.createElement("div");
        let closeButton = document.createElement("button");

        dialogHeader.classList.add("dialogHeader");
        h5.innerText = "Error";
        dialogHeader.appendChild(h5);

        dialogContent.classList.add("dialogContent");
        p.innerText = "Unable to set the theme for this site. The quota could be exceeded or storage could be disabled for this site. The theme will be set to system.";
        dialogContent.appendChild(p);

        dialogFooter.classList.add("dialogFooter");
        closeButton.classList.add("siteButton");
        closeButton.innerText = "Close";
        closeButton.addEventListener("click", function closeButtonClick() {
            dialog.close();
        });
        dialogFooter.appendChild(closeButton);

        dialog.appendChild(dialogHeader);
        dialog.appendChild(dialogContent);
        dialog.appendChild(dialogFooter);

        document.body.appendChild(dialog);
        dialog.showModal();
    }

    return preferredTheme;
}