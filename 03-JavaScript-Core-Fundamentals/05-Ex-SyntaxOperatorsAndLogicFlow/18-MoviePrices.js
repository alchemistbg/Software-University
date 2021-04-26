function solve([movie, day]) {
    if (movie.toLowerCase() === "The Godfather".toLowerCase()) {
        switch (day.toLowerCase()) {
            case "monday":
                console.log(12);
                break;
            case "tuesday":
                console.log(10);
                break;
            case "wednesday":
                console.log(15);
                break;
            case "thursday":
                console.log(12.50);
                break;
            case "friday":
                console.log(15);
                break;
            case "saturday":
                console.log(25);
                break;
            case "sunday":
                console.log(30);
                break;
            default:
                console.log("error");
                break;
        }
    }else if (movie.toLowerCase() === "Schindler's List".toLowerCase()) {
        switch (day.toLowerCase()) {
            case "monday":
                console.log(8.50);
                break;
            case "tuesday":
                console.log(8.50);
                break;
            case "wednesday":
                console.log(8.50);
                break;
            case "thursday":
                console.log(8.50);
                break;
            case "friday":
                console.log(8.50);
                break;
            case "saturday":
                console.log(15);
                break;
            case "sunday":
                console.log(15);
                break;
            default:
                console.log("error");
                break;
        }
    }else if (movie.toLowerCase() === "Casablanca".toLowerCase()) {
        switch (day.toLowerCase()) {
            case "monday":
                console.log(8);
                break;
            case "tuesday":
                console.log(8);
                break;
            case "wednesday":
                console.log(8);
                break;
            case "thursday":
                console.log(8);
                break;
            case "friday":
                console.log(8);
                break;
            case "saturday":
                console.log(10);
                break;
            case "sunday":
                console.log(10);
                break;
            default:
                console.log("error");
                break;
        }
    }else if (movie.toLowerCase() === "The Wizard of Oz".toLowerCase()) {
        switch (day.toLowerCase()) {
            case "monday":
                console.log(10);
                break;
            case "tuesday":
                console.log(10);
                break;
            case "wednesday":
                console.log(10);
                break;
            case "thursday":
                console.log(10);
                break;
            case "friday":
                console.log(10);
                break;
            case "saturday":
                console.log(15);
                break;
            case "sunday":
                console.log(15);
                break;
            default:
                console.log("error");
                break;
        }
    }else{
        console.log("error");
    }
}

solve(["The Godfather", "Friday"]);
solve(["casablanca", "sunday"]);
solve(["Schindler's LIST", "monday"]);
solve(["SoftUni", "Nineday"]);