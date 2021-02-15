build:
	(cd ./Assets/Plugins/CandyCoded.HapticFeedback/Plugins/Android && build-unity-android-plugin -p com.candycoded.hapticfeedbacklibrary AndroidPlugin.java)

deploy:
	git subtree push --prefix Assets/Plugins/CandyCoded.HapticFeedback origin upm

deploy-force:
	git push origin `git subtree split --prefix Assets/Plugins/CandyCoded.HapticFeedback main`:upm --force

clean:
	git clean -xdf
