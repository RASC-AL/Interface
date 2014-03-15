call env.bat

gst-launch udpsrc port=30000 ! "application/x-rtp, payload=96, clock-rate=90000, do-timestamp=true" ! rtph264depay ! ffdec_h264 ! videorate ! d3dvideosink sync=false 
