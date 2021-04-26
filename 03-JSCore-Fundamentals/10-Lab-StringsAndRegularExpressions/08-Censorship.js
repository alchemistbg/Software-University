function solve(text, query) {
    for (let i = 0; i < query.length; i++) {
        while(text.includes(query[i])){
            text = text.replace(query[i], '-'.repeat(query[i].length))
        }
    }
    console.log(text);
}

solve('roses are red, violets are blue', [', violets are', 'red']);
console.log();
solve('David Ruben Piqtoukun (born 1950) is an Inuit artist from Paulatuk, Northwest Territories. His output includes sculpture and prints; the sculptural work is innovative in its use of mixed media. His materials and imagery bring together modern and traditional Inuit stylistic elements in obj1 personal vision. An example of this is his work "The Passage of Time" (1999), which portrays obj1 shaman in the form of obj1 salmon moving through obj1 hole in obj1 hand. While shamanic imagery is common in much of Inuit art, the hand in this work is sheet metal, not obj1 traditional material such as walrus ivory, caribou antler or soapstone. Ruben\'s brother, Abraham Apakark Anghik Ruben, is also obj1 sculptor. Fellow Inuit artist Floyd Kuptana learned sculpting techniques as an apprentice to David Ruben.', ['Inuit']);