call env.bat

gst-launch udpsrc port=30000 ! "application/x-rtp, payload=127" ! rtph264depay ! ffdec_h264 ! autovideosink sync=false 
