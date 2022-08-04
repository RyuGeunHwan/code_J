## vscode로 개발환경 sync 설정하기

<a href="https://gist.github.com/dimmby/86d86873a8a79956df6beb38fcea6fcc">https://gist.github.com/dimmby/86d86873a8a79956df6beb38fcea6fcc</a>

```
1. github 로그인 후 "https://gist.github.com/dimmby/86d86873a8a79956df6beb38fcea6fcc" 접속해서 Fork 버튼을 클릭해서 레파지토리에 복사(자동으로 나의 Gists페이지로 넘어감.)

2. vscode 확장 프로그램에서 Settings Sync 다운받기.

3. LOGIN WITH GITHUB 클릭해서 github와 연결되면 Gist 자동 생성 됨.

4. F1 눌러서 Sync: Advanced Option 클릭 -> sync: 설정 열기 클릭.

5. 본인 깃허브 로그인한 Gist ID, 엑세스 토큰 작성되어있음.

6. 체크리스트는 Force Download,Force Upload,Remove Extensions,Sync Extensions 체크.

7. F1 눌러서 Sync: Update/Upload Settings 클릭.

8. F1 눌러서 Sync: Download Settings 클릭.

```

### 다른사람 설정해 줄 경우

<a href="hhttps://gist.github.com/RyuGeunHwan/e4c217f57722b9822d3c5ea8defe93a1">"https://gist.github.com/RyuGeunHwan/e4c217f57722b9822d3c5ea8defe93a1"</a>

```
	5번 대신
		sync: 설정 열기에서 Gist ID와 액세스 토큰을 설정되어있는 사람 것으로 변경해서 입력 
		"https://gist.github.com/RyuGeunHwan/e4c217f57722b9822d3c5ea8defe93a1"
		주소로 들어가서 ' Download ZIP ' 클릭해서 다운로드하고 압축 풀기
		경로 : %AppData%\Code\User 에 압축풀은 파일 덮어쓰기
```

## 3번 첫화면

![sync-1](img/%EC%BA%A1%EC%B2%98.PNG)

## 3번 두번째 화면

![sync-2](img/%EC%BA%A1%EC%B2%981.PNG)

## 4번 sync 설정 화면
![sync-3](img/%EC%BA%A1%EC%B2%982.PNG)

## F1 클릭 화면
![sync-4](img/%EC%BA%A1%EC%B2%983.PNG)