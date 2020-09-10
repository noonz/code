#!/bin/bash
DATE=$(date +"%Y-%b%d_%H%M%S")
raspivid -t 0 -o /home/pi/camera/videos/video-$DATE.h264
