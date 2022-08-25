비동기 처리 패턴 중 하나의 문법

# promise : return값이 promise일 경우 resolve가 넘어갈 경우 the을 reject(error)가 넘어갈 경우 catch를 이용한다.	
- <a src="https://learnjs.vlpt.us/async/01-promise.html">promise 참고사이트1</a><br>
- <a src="https://joshua1988.github.io/web-development/javascript/promise-for-beginners/">promise 참고사이트2</a><br>
- <a src="https://www.youtube.com/watch?v=JB_yU6Oe2eE">promise 참고 영상</a><br>
```	
	+ 언제 사용(비동기적인 처리) 되는데???	
		1. 어떠한 명령을 실행할 때 그 명령이 언제 끝날지 예측하기 어려울 때.
		2. 주가 되는 작업이 아닐때 비동기적인 처리를 많이한다.
		대표적인 예) 서버와 웹 브라우저 통신
		
	+ 어떻게 data가 전달 되는가???
		1. 함수(A)안에 promise를 return해주면서 resolve파라미터에 data를 넣어준다.
		2. 함수(A)를 호출해서 첫번째 .then의 콜백함수 파라미터에 resolve()의 결과값이 들어가게 된다.
	  ex) 예제1) promise 기초를 예를 들면 promise함수 resolve파라미터에 1이 들어가있다. 
		  getData.then(콜백함수(){})를 사용하게되면 콜백함수 파라미터에 resolve()의 결과값인 1이 들어가게된다.

	+	fetch : 'A Promise th at resolves to a Response object.' => fetch의 return값은 Promise이고 함수(fetch)가 성공적으로 실행이되면 Response라는 object를 줄 것이다.
				 즉, fetch도 .then  ,  .catch 를 사용할 수 있다.
		
	+	resolve --> then이 호출 될 때 : fetch를 통해서 실행한 결과가 "성공"했을때 then으로 전달된 콜백 함수(function(resolved){})가 호출된다. 결과는 파라미터의 변수로 들어간다.
						
	+	reject --> catch이 호출 될 때 : fetch를 통해서 실행한 결과가 "실패"했을때 catch로 전달된 콜백 함수가 호출된다. 실패의 이유는 파라미터의 변수로 들어간다.
		
		- Nested promise : then안에 then을 처리하는 방식(주석한 구간)
		- promise chaining : response.json()을(promise) return하여 then과 then을 연결하는 방식 
```
```html
		<!-- 예제1) promise 기초 -->
			<script>
			function getData(){
				new Promise(function(resolve, reject){
				  setTimeout(function() {
					resolve(1);
				  }, 2000); //2초뒤에 실행
				});
			}
			
			getData()
				.then(function(result) { // 콜백함수 파라미터값인 result == return된 Promise의 값을 말한다.
				  console.log(result); // 1
				  return result + 10; // promise를 return(.then에서 return을 하게되면 promise가 return이 된다.)
				})
				.then(function(result) {
				  console.log(result); // 11
				  return result + 20;
				})
				.then(function(result) {
				  console.log(result); // 31
				});
			</script>
		
		
		<!-- 예제2) promise 기본 -->
			<script>
			+ // new Promise()로 프로미스 객체를 생성하면 콜백 함수 인자로 resolve와 reject를 사용할 수 있다
				new Promise(function(resolve, reject){
					
				});
				
				
			+	// Pending(대기) : 비동기 처리 로직이 아직 완료되지 않은 상태
					new Promise();
			
				
			+	// Fulfilled(이행) : 비동기 처리가 완료되어 프로미스가 결과 값을 반환해준 상태
					function getData(){
						return new Promise(function(resolve, reject){
							var data = 100;
							resolve(data);
						});
					}
					// resolve()의 결과 값 data를 resolvedData로 받음
					getData()
						.then(function(resolvedData) {  // then은 함수 실행에 성공 하였을때 then콜백 함수를 실행한다.
						console.log(resolvedData); // result ==> 100
					});
					
					
			+	// Rejected(실패) : 비동기 처리가 실패하거나 오류가 발생한 상태
					function getData() {
					  return new Promise(function(resolve, reject) {
						reject(new Error("Request is failed"));
					  });
					}

					// reject()의 결과 값 Error를 err에 받음
					getData()
						.then()
						.catch(function(err) {	// catch는 함수 실행에 실패 하였을때 catch콜백 함수를 실행한다.
							console.log(err); // Error: Request is failed
					});
			</script>


		<!-- 예제3) promise 실용 -->
			<script>
				fetch('URL주소')
					.then(function(resolved){ //서버에서 응답이 성공하면 then 콜백함수 실행
				//		resolved.json().then(function(data){
				//			console.log('data',data);
				//		});
						return resolved.json(); //promise를 return
					})
					.catch(function(rejected){
						console.log('rejected',rejected);
					})
					.then(function(data){
						console.log('data',data)
					});
			</script>
		
			
			
		<!-- 예제4) 화살표 함수를 이용한 promise  -->
		<script>
			function increaseAndPrint(n) {
			  return new Promise((resolve, reject) => {
				setTimeout(() => {
				  const value = n + 1;
				  if (value === 5) {
					const error = new Error();
					error.name = 'ValueIsFiveError';
					reject(error);
					return;
				  }
				  console.log(value);
				  resolve(value);
				}, 1000);
			  });
			}

			increaseAndPrint(0)
			  .then(n => {
				return increaseAndPrint(n);
			  })
			  .then(n => {
				return increaseAndPrint(n);
			  })
			  .then(n => {
				return increaseAndPrint(n);
			  })
			  .then(n => {
				return increaseAndPrint(n);
			  })
			  .then(n => {
				return increaseAndPrint(n);
			  })
			  .catch(e => {
				console.error(e);
			  });
			  
			//   Result ==> 1, 2, 3, 4, Error
		 </script>
```