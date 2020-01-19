# ToW
Thoughts of Worship App (Android)

WebView app of the Thoughts of Worship website, which can be found here: https://thoughtsofworship.weebly.com/
*Note* This is the second iteration of the app, as I lost the files to the first one (a reason for me putting this one on GitHub)

To run it, there's to options
  Option 1:
     Use one of the APKs in the Release tab
     Load it onto an android device with at least Android Oreo (8.0)
  Option 2:
      Download the source code and open the solution in Visual Studios
      If you have all the proper libraries installed (Xamarin) then hook up a device for deployment or use an emulator
      F5 should build it and deploy it to the device
      If there are any issues let me know. I'm new to using GitHub for my own repositories, so I'm a little unsure to how well the pushing and cloning works
      
 Known Issues (It's still a work in progress)
      It loads pretty slowly (in my opinion), which makes sense since I'm loading several webpages on bootup
          I'll work on better way of doing this
      Links open to the devices browser rather then in the app
          Not too sure as to why yet, but I'll see what I can find
  
  Planned Features
      Better back button support
      An actual settings view
      A developed about page
      A working bug reporting view
          We'll see how far I get with this one. I've never done cloud based stuff, so that learning curve is going to be slow)
      Maybe a refresh button or a refresh gesture 
          i.e swiping down hard or while at the top of the webpage will refresh
      An app icon
          Like I said, I lost the files to my original, so I have to remake it. 
            Luckily I still have the original installed on my phone, so I've been using that as the template
      Possibly Notifications
          I'd have to figure out how to check if a new blog has been posted
      Going to webparsing instead of webviews
          That'll take a while to figure out (I wonder if Weebly has an API...)
      A boot animation that actually waits till the app is loaded
          I couldn't figure it out on the original, but I've got a few ideas
      Smaller app size
          I have no idea why it's so big
              53 MBs for some webviews
                  My guess is all the app icon sizes that all get installed in the Ad-Hoc APK
                  That or it has something to do with the Xamarin libraries
      Maybe move from Xamarin to C++
           Actually having it built on C++ would be ideal
