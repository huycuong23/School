const list = document.querySelectorAll(".silde-img");
const app = {
  activeIndex: 0,
  deleteActive() {
    document.querySelector(".silde-img.active").classList.remove("active");
  },
  itemLenght: 5,
  timeInterval: 3000,
  mysetInterval() {
    setInterval(function () {
      if (app.activeIndex === app.itemLenght) {
        app.activeIndex = 0;
      } else {
        app.activeIndex++;
      }
      app.deleteActive();
      list[app.activeIndex].classList.add("active");
    }, this.timeInterval);
  },
  add() {
    list[app.activeIndex].classList.add("active");
  },
};
function auto() {
  app.mysetInterval();
}
function next() {
  if (app.activeIndex === app.itemLenght) {
    app.activeIndex = 0;
  } else {
    app.activeIndex++;
  }
  app.deleteActive();
  app.add();
}
function pre() {
  if (app.activeIndex === 0) {
    app.activeIndex = app.itemLenght;
  } else {
    app.activeIndex--;
  }
  app.deleteActive();
  app.add();
}
function first() {
  app.activeIndex = 0;
  app.deleteActive();
  app.add();
}
function last() {
  app.activeIndex = app.itemLenght;
  app.deleteActive();
  app.add();
}
function stop() {
  app.deleteActive();
  app.add();
  clearInterval(app.mysetInterval);
}