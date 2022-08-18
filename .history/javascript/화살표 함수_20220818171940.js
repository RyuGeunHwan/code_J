 // 화살표함수는 함수를 선언하는 방법에 있어서 화살표를 이용해서 선언한 함수
 // 화살표 함수는 함수를 식별할 수 있는 식별자가 없으므로 '함수 표현식' 즉, 변수로 표현을 해주어야 한다.




 

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
// result : 30
 
// 함수의 매개변수가 한개라면 소괄호도 생략할 수 있다.
const parameter = (num) => num + num ;
//  === function parameter(num){
//          return num+num;
//}

console.log(parameter(17));
// result : 34








// 화살표 함수가 객체를 반환하고 있을경우 객체를 소괄호로 한번 더 묶어준다.
//(화살표 함수 안에 코드가 바로 return키워드 일때 중괄호와 return은 생략가능)

// const getObject = () => {                         
//     return {                                        
//         name : '류근환',                            
//         age : 28                                
//     }                                                   
// }                     

const getObject = () => ({ name : '류근환', age : 28 })

console.log(getObject().name);