# TimingSolutions
My approach. I am used to running everything in VS and realised this wasn't going to work for both server and client, so tried running the client in IIS, then realised that they are both using the same IP Address. I then realised i can run the client just in a browser.

My intention wwas to receive the sessionID in the listener, then use the data model from http://dev-sample-api.tsl- timing.com/ to create a response and varying the values periodically to simulate real-world results which would show back in the client.

I did have a look at using React for the client but figured it would take too long to build enough of it to be meaningfull.

I did manage to get the listener to recieve the request but was struggling to grab the sessionID from it. I decided to use for the client and used an online vanilla JS example then I could at least attempt to debug it in a familiar way. I am more used to working on the receving end of very complex APIs, each one very different. So doing both server and client I did find a struggle. With more time and some training I could break this down into smaller sections and create it, but it's a bit out of my current comfort zone. I am largely self-taught and learning new stuff can take some time, but I am pretty good at it and I have developed very good diagnostic and debugging skills too. I will submit this anyway, there are few commmits as my progress was tedious. Thanks for the opprtunity.

Ralph Beardmore

