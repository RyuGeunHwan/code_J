# NIA #

# KOREN 기반 자율형 네트워크 기술 실증 

# Legacy NMS 의 한계(Human-oriented )
	+ 네트워크 계층 및 단일 기술 도메인별 네트워크 관리
	+ 모니터링, 장애 인지/분석/조치 등 모든 관제 업무를 운용자에 의존
	+ 장애 발생 시 대량의 알람/로그 중복 발생
	+ 운용자 중심의 다단계 원인 분석 및 조치
	+ 지역/전국 운용자별 기량 차이 발생
	+ 수동 상황전파로 인해 신속한 근원 경보 파악이 어려움. 
	
## WEB 접속
	//://116.89.186.194:8080 
	//admin/admin
	
	://116.89.191.47:8080/
	admin/admin
	
# 개발환경 설정
	0. 
	1. 개발(D:\Work\KTRCA\workspace\rca\개발환경세팅(최소).md 참고)
		+ JDK 설치
			1. jdk-8u162-windows-x64.exe 설치
				D:\Google 드라이브\Project\Orviche\개발환경\jdk-8u162-windows-x64.exe
				https://www.oracle.com/kr/java/technologies/javase/javase8-archive-downloads.html
				https://www.oracle.com/kr/java/technologies/javase/jdk11-archive-downloads.html
			2. 환경변수 세팅
				setx JAVA_HOME "C:\Program Files\Java\jdk1.8.0_162"
		+ npm - [설치파일 Download]
		{
			https://nodejs.org/ko/download/releases/
			https://nodejs.org/download/release/v10.1.0/node-v10.1.0-x64.msi
			
			vert.x 용
			D:\Work\_툴/node-v10.1.0-x64.msi
			node -v; npm -v; "v10.1.0 , 5.6.0"	 (RCA, dax2 기준)
		}
			
		+ [git-bash](http://git-scm.com/)
			* https://github.com/git-for-windows/git/releases/download/v2.24.1.windows.2/Git-2.24.1.2-64-bit.exe
			* 반드시 선택 Git from the comand line and also form 3rd-party software
			* 개발환경설정 
				설치
					$ npm install -g babel-cli babel-preset-es2015;
					$ npm install -g jspm http-server gulp-cli gulp bower jspm-bower-endpoint grunt;
				제거
					$ npm uninstall -g babel-cli babel-preset-es2015;
					$ npm uninstall -g jspm http-server gulp-cli gulp bower jspm-bower-endpoint grunt; npm cache clean;
				확인
					$ npm list --depth=0 -g 
				디버깅
					$ cd app
					$ npm install
					$ jspm registry create bower jspm-bower-endpoint
					$ jspm install
				빌드/배포
					1. gradle 설치 작업
					2. gulp build 또는 D:\Work\KTRCA\workspace\rca\build\libs\step1_buildweb.bat
						[에러] buildweb.bat 실행 시 Error: Couldn't find preset "es2015" relative to directory
							1. npm install babel-cli babel-preset-es2015 -g
							2. 상위 폴더 중에 .babelrc 가 정의 되어 있으면 안된다. 
					3. D:\Work\KTRCA\workspace\rca\build\libs\step2_build.bat
			* 문제해결 
				1. -bash: ll: command not found
					echo "alias ll='ls -alF'" >> ~/.bashrc
					source ~/.bashrc
		+ gradle 설치
			윈도우 gradle 설치 https://zetawiki.com/wiki/윈도우_gradle_설치
			{
				1. 다운로드 https://downloads.gradle.org/distributions/gradle-4.6-all.zip
				2. 이름변경 gradle-4.6 -> gradle
				3. 폴더이동  D:\Program Files\ 아래로 이동
				4. Path 추가	Path=D:\Program Files\gradle\bin;
				5. 확인
					C:\Windows\System32>gradle -v
				6. gradlew 명령어가 안될시 gradle wrapper 명령어로 와퍼 설치후 다시 실행
			}
		+ Intellj 설치 (D:\Google 드라이브\Local_Sync\notepad++\intelliJ 설정.md 참고)
			* D:\backup\IntilliJ IDEA Ultimate\JetBrains IntelliJ IDEA Ultimate 2018.3\1.JetBrains IntelliJ IDEA Ultimate 2018.3 Windows\ideaIU-2018.3.exe
			* 크랙 방법
				- 파일복사 
					D:\backup\IntilliJ IDEA Ultimate\JetBrains IntelliJ IDEA Ultimate 2018.3\2.Jetbrains 2018.3 Rover Patch v3.4 2018-11-25\JetbrainsIdesCrack-3.4-release-enc.jar
					-> C:\Program Files\JetBrains\IntelliJ IDEA 2018.3\bin 
				- 맨 끝에 추가 notepad C:\Program Files\JetBrains\IntelliJ IDEA 2018.3\bin\idea64.exe.vmoptions
					-javaagent:C:\Program Files\JetBrains\IntelliJ IDEA 2018.3\bin\JetbrainsIdesCrack-3.4-release-enc.jar
				- 라이센스키입력
					ThisCrackLicenseId ... 
			* 바로가기 바탕화면으로 가져오기 D:\Work
			* 설정가져오기 (D:\backup\IntilliJ IDEA Ultimate\settings.zip)

# EMAIL
	서버IP 	203.255.250.123
	계정 	infobiz@koren.kr // infobiz
	허용해준 클라이언트 IP 183.107.19.138
	+ 아웃룩 설정
		사용자이름: infobiz
		전자메일주소: infobiz@koren.kr
		계정유형: POP3
		받는메일서버: 203.255.250.123
		보내는메일서버: 203.255.250.123
		사용자이름: infobiz
		암호: infobiz
		암호저장: 체크
		SPA(보안암호인증) 사용한 로그인: 체크없음
		고급 :
			받는메일서버(POP3) 110
			보내는메일서버(SMTP) 25
	+ 2022 년도 새계정
		계정: codej@koren.kr
		비밀번호: zhemwpdl!@# (코드제이!@#)
		서버: 203.255.250.101 
		***주의***  반드시 koren 망에서 아웃룩을 설정해야한다. 외부망에서는 110번 포트가 막혀있다.
	
# html EDITOR
https://stackoverflow.com/questions/36079280/rich-text-editor-for-angularjs
https://ghinda.net/angular-meditor/

# 인포비즈 NAS SVN	(dimmby/dimmby)
	svn://192.168.0.2/NIA/UI/nia
	svn://183.107.19.138/NIA/UI/nia
	DB:
		db.url=jdbc:postgresql://183.107.19.138:8000/niadb
		db.driver=org.postgresql.Driver
		db.poolmax=1000
		db.username=niaadmin
		db.pw=niaadmin12#$
	MQ
		rabbitmq.host=183.107.19.138
		rabbitmq.port=8001
		rabbitmq.user=niaadmin
		rabbitmq.pw=niaadmin12#$
	ssh [개발]
		192.168.0.87:2200
		niaadmin@niaadmin12#$
	ssh [운영]
		숨겨진 네트워크 8888 입력 pw: qorentks12#$ (백두산12#$) 
		SSH 116.89.186.194:22  koren0901 / 자유와빵!
		DB	116.89.186.194:5433
			database : niadb
			id : niaadmin
			pw : niaadmin12#$

## 테스트DB
db.url=jdbc:postgresql://192.168.0.87:5433/niadb
db.driver=org.postgresql.Driver
db.poolmax=1000
db.username=niaadmin
db.pw=niaadmin12#$

## RabbitMQ
192.168.0.87:5675 
id : niaadmin
px : niaadmin12#$

# 11.05 UI 스토리보드 
+ 추가요구사항
* 디자인
	장비아이콘, RCA 문구, KOREN 대문자로
* 메일전송
	- koren.kr 메일로 보내고 싶다. noc@koren.kr
	- 임계치 설정 후 티켓 생성되면 설정해놓은 작업자에게 자동 메일 발송 가능?
	- 현재 담당자로 설정되어있는 권한로직이 수정되어야 할 수 도 있음.
		장비모델별 지역별 조건에 따라 메일 발송을 다르게 할 수 있는 화면이 필요할 수 도 있다. 
* 티켓 상세정보. 추가
	- 티켓 상세정보 열람 후.... 조치가이드 까지 일괄적으로 처리하는 화면이 있으면 좋겠다.
* 토폴로지 필터
	- 장비가 많이  추가 되었을 경우 장비 필터가 필요 할 수 동 ㅣㅆ다. 
	- 지역별, 장비타입/레이어별 ...
* 통계페이지 고려
	- 일정기간 동안 지역별 발생 티켓 추이
	- 어떤 통계가 필요한지 정의가 필요
	
