build:
	(cd ./AndroidPlugin/ && ANDROID_SDK_ROOT=~/Library/Android/sdk ./gradlew assembleRelease)
	rm -f ./Assets/Plugins/CandyCoded.HapticFeedback/Plugins/Android/*.aar
	find ./AndroidPlugin/app -type f -name "*.aar" -exec cp {} ./Assets/Plugins/CandyCoded.HapticFeedback/Plugins/Android/ \;

deploy:
	git subtree push --prefix Assets/Plugins/CandyCoded.HapticFeedback origin upm

deploy-force:
	git push origin `git subtree split --prefix Assets/Plugins/CandyCoded.HapticFeedback main`:upm --force

clean:
	git clean -xdf
