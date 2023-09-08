var listImg = document.querySelectorAll(".menu-left__img");
var listTitle = document.querySelectorAll(".item-text");
const app = {
    active: 1,
    removeActiveImg() {
        document.querySelector(".menu-left__img.active").classList.remove("active");
        document.querySelector(".item-text.active").classList.remove("active");
    },
    render() {
        for (item of listImg) {
            if (item.dataset.index == app.active) {
                item.classList.add("active");
            }
            else;
            //nothings
        }
        for (item of listTitle) {
            if (item.dataset.index == app.active) {
                item.classList.add("active");
            }
            else;
            //nothings
        }
    }
}
function changer(index) {
    app.active = index;
    app.removeActiveImg();
    app.render();
}