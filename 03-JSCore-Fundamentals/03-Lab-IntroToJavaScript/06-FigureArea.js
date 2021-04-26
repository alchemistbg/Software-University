function solve(w, h, W, H){
    let area1 = w*h;
    let area2 = W*H;
    let area3 = Math.min(w, W)*Math.min(h, H);
    let totalArea = area1 + area2 - area3;
    console.log(totalArea);
}

solve(2, 4, 5, 3);
solve(13, 2, 5, 8);
solve(1, 1, 2, 2);
solve(12.45, 23.266, 10.145, 28.561);