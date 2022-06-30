const numberArr = [1, 2, 3];

const generateAverage = (numberArr) => {
    let score = 0;
    for (let index = 0; index < numberArr.length; index++) {
        score += numberArr[index];
    }
    return score;
};

console.log(generateAverage(numberArr));
