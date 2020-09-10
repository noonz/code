#!/bin/bash
DATE=$(date +"%Y-%b%d_%H:%M:%S")
raspistill -o /home/pi/camera/pictures/image-$DATE.jpg
