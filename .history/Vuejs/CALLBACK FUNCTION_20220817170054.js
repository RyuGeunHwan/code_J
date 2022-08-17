	
1. 	
	const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];
	
	function callback(element){ //words배열의 요소들을 파라미터 값으로 입력
		console.log(element); // element의 값 => spray limit elite exuberant destruction present
		if(element.length>6){ //요소의 길이가 6글자보다 많으면...
			return true;
		}else{
			return false;
		}
	}
	newWords=words.filter(callback); //words 배열에서 callback함수를 필터링 함.
	console.log(newWords)


Result ==> 
	(3) ['exuberant', 'destruction', 'present']



===


2. 1번을 간소화
	const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];
	function callback(element){
		return element.length>6;
	}
	newWords=words.filter(callback);
	console.log(newWords)


Result ==> 
	(3) ['exuberant', 'destruction', 'present']



===



3. 2번을 간소화
	const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];

	newWords=words.filter(function(element){
		return element.length>6;
	});
	console.log(newWords)


Result ==> 
	(3) ['exuberant', 'destruction', 'present']
	
	
	
	
	
===	
	
	
	
	
4. 3번을 간소화 + 화살표 함수 이용
	const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];

	newWords=words.filter((element)=>{
		return element.length>6;
	});
	console.log(newWords);

==>
	const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];
	
	newWords=words.filter(element => element.length>6); //코드가 한 줄인 경우 return키워드, 중괄호 필요없음.
	console.log(newWords);



Result ==> 
	(3) ['exuberant', 'destruction', 'present']
	
	
	
	
5. myfilter라는 함수 만들기
	const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];
		
	function myfilter(origin, callback){
			var result = [];
			for(var i=0; i<origin.length; i++){
				var current = origin[i];
				if(callback(current)){
					result.push(current)
				}
			}
			return result;
	}
	newWords=myfilter(words, element => element.length>6);
	console.log(newWords);