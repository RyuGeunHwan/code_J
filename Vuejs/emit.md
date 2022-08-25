# $emit
- <a src="https://www.youtube.com/watch?v=k1cZiYKZxKs">$emit() 참고영상</a><br>
- <a src="https://velog.io/@ducks1077/Vue.js-props-emit-%EA%B0%9C%EB%85%90-%EC%A0%95%ED%99%95%ED%95%98%EA%B2%8C-%EC%9E%A1%EA%B8%B0">$emit() 참고 사이트</a><br>

# emit 이벤트 발생과 수신
```
	+ 이벤트 발생과 수신은 '$emit()'과 'v-on:' 속성을 사용한다.
		ex) // 이벤트 발생(하위 컴포넌트)
				this.$emit('이벤트 명');
			1. $emit()호출하면 괄호 안에 정의된 이벤트가 발생
			2. $emit()을 호출하는 위치는 하위 컴포넌트의 특정 메서드 내부이기 때문에
				사용하는 this는 하위 컴포넌트를 가리킨다.
				
			// 이벤트 수신(하위 컴포넌트에서 상위 컴포넌트로 데이터 전달)(상위 컴포넌트)
				<child-component v-on:이벤트명="상위 컴포넌트의 메서드명"></child-component>
			1. 호출한 이벤트는 하위 컴포넌트를 등록하는 태그(상위 컴포넌트의 template 속성에 위치)에서 v-on:으로 받는다.
			2. 하위 컴포넌트에서 발생한 이벤트명을 v-on: 속성에 지정하고, 속성의 값에 이벤트가 발생했을 때 호출될 상위 컴포넌트의 메서드를 지정한다.
```

<img src="../img/%24emit().png" width="" height="950px" title="30px" alt="$emit()"></img>
<img src="../img/emit%EC%8B%A4%ED%96%89.PNG" width="60%" height="" title="30px" alt="$emit()실행"></img>








