비동기 처리 패턴 중 하나의 문법
- <a src="https://joshua1988.github.io/web-development/javascript/js-async-await/">async/await 참고 사이트</a><br>
- <a src="https://www.youtube.com/watch?v=aoQSOZfz3vQ&t=249s">async/await 참고 영상</a><br>

# async : 
```
	평범한 함수에 promise를 return하게하여 비동기적 함수로 만들어주는 키워드. 
	async의 함수는 return 값이 promise이다.
```
# await :
``` 
	'함수가 실행되기를 기다리라는 뜻', await는 다른 함수 안에서 실행 되어야한다. 
	 다른 함수라는 함수 앞에는 async라는 키워드가 앞에 붙어있어야한다.
```
```html
	<!-- 예제1)  -->
		<script>
			function timer(time){
				return new Promise(function(resolve){
					setTimeout(function(){
						resolve(time);
					}, time);
				});
			}
			
			// console.log('start');
			// timer(1000) // then을 사용할 수 있는 이유는 timer()의 return값이 promise이기 때문.
			// 	.then(function(time){
			// 		console.log('time : ' + time); //result => 'time : 1000'
			// 		return timer(time + 1000); //기존 timeout 시간에 1초를 더한 시간만큼 지연.
			// 	})
			// 	.then(function(time){
			// 		console.log('time : ' + time); //result => 'time : 2000'
			// 		return timer(time + 1000);
			// 	})
			// 	.then(function(time){
			// 		console.log('time : ' + time); //result => 'time : 3000'
			// 		console.log('end');
			// 	});
			 
			 async function run(){
				console.log('start');
				 var time = await timer(1000);  //비동기적인 코드다 라는 것을 분명히 하기 위해서 await 키워드 작성
				 // 변수time : then 안에 첫번째 파라미터는 await를 쓰면 timer의 return값으로 받을 수 있다.
				 console.log('time : ' + time);
				 time = await timer(time+1000);
				 console.log('time : ' + time);
				 time = await timer(time+1000);
				 console.log('time : ' + time);
				 console.log('end');
			}
			run();
		</script>
		
	<!-- 예제2) 순서대로 동기적 방식으로 실행 -->
		<script>
			function sleep(ms) {
			  return new Promise(resolve => setTimeout(resolve, ms));
			}

			const getDog = async () => {
			  await sleep(1000);
			  return '멍멍이';
			};

			const getRabbit = async () => {
			  await sleep(500);
			  return '토끼';
			};
			const getTurtle = async () => {
			  await sleep(3000);
			  return '거북이';
			};

			async function process() {
			  const dog = await getDog();
			  console.log(dog);
			  const rabbit = await getRabbit();
			  console.log(rabbit);
			  const turtle = await getTurtle();
			  console.log(turtle);
			}

			process();
			//현재 위 코드에서는 getDog 는 1초, getRabbit 은 0.5초, getTurtle 은 3초가 걸리고 있습니다.
			// 이 함수들을 process 함수에서 연달아서 사용하게 되면서, process 함수가 실행되는 총 시간은 4.5초가 됩니다.
		</script>
		


	<!-- 예제3)동시에 작업하고 싶을 때 ' Promise.all '을 사용 -->
	<script>
		function sleep(ms) {
		  return new Promise(resolve => setTimeout(resolve, ms));
		}
	
		const getDog = async () => {
		  await sleep(1000);
		  return '멍멍이';
		};
	
		const getRabbit = async () => {
		  await sleep(500);
		  return '토끼';
		};
		const getTurtle = async () => {
		  await sleep(3000);
		  return '거북이';
		};
	
		async function process() {
		  const results = await Promise.all([getDog(), getRabbit(), getTurtle()]);
		  console.log(results);
		}
	
		process();
		// Result ==> ['멍멍이','토끼','거북이']
		// Promise.all 를 사용 할 때에는, 등록한 프로미스 중 하나라도 실패하면, 모든게 실패 한 것으로 간주합니다.
	</script>
```
	
