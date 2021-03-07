function solve(input) {
    let capitalWords = [];
    let strArr = input.join(",").split(/\W+/).filter(x => x.length > 0);
    for (let i = 0; i < strArr.length; i++) {
        let capString = strArr[i].toUpperCase();
        if(capString == strArr[i]){
            capitalWords.push(strArr[i])
        }
    }
    console.log(capitalWords.join(", "));
}

solve(["We start by HTML, CSS, JavaScript, JSON and REST.",
    "Later we touch some PHP, MySQL and SQL." ,
    "Later we play with C#, EF, SQL Server and ASP.NET MVC." ,
    "Finally, we touch some Java, Hibernate and Spring.MVC."]);