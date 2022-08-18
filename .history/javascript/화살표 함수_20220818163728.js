 // 화살표함수는 함수를 선언하는 방법에 있어서 화살표를 이용해서 선언한 함수
 // 화살표 함수는 함수를 식별할 수 있는 식별자가 없으므로 함수 표현식 즉, 변수로 표현을 해주어야 한다.


// function sum(num1,num2){
//     return num1 + num2;
// }

// const sum = (num1,num2) => {
    //     return num1 + num2;
    // }
//중괄호(함수)안에 로직이 return밖에 없다면 아래의 코드와 같이 중괄호가 생략 가능하다.
 
const sum = (num1,num2) => num1+num2;

const result = sum(10, 20);
console.log(result);
 
// 함수의 매개변수가 한개라면 소괄호도 생략할 수 있다.
const parameter = (num) => num + num ;
//  === function parameter(num){
//          return num+num;
//}

console.log(parameter(17));