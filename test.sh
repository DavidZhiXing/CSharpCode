// undo last git commit

git reset --hard HEAD~1

// use youtube-dl to download video
youtube-dl -f bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4 $1

// use youtube-dl to download all videos in a playlist
youtube-dl -f bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4 $1 --yes-playlist

// use youtube-dl to download all videos from a channel
youtube-dl -f bestvideo[ext=mp4]+bestaudio[ext=m4a]/mp4 $1 --yes-playlist --playlist-reverse

// use youtube-dl to download a video from url
