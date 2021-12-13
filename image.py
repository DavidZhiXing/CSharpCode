# import Image library
from PIL import Image
# import ImageGrab library
import ImageGrab

# get a shot cut of the screen

def get_shot_cut(x, y, w, h):
    # get the screen shot
    im = ImageGrab.grab(bbox=(x, y, x + w, y + h))
    # save the screen shot
    im.save('shot_cut.png')
    # return the screen shot
    return im

# get the current active window size
def get_active_window_size():
    # get the active window size
    active_window_size = ImageGrab.grab().size
    # return the active window size
    return active_window_size

# get the region by mouse click and drag
def get_region_by_mouse_click_and_drag(x, y, w, h):
    # get the region by mouse click and drag
    region = ImageGrab.grab(bbox=(x, y, x + w, y + h))
    # return the region
    return region

# rotate the image
def rotate_image(im, angle):
    # rotate the image
    im = im.rotate(angle)
    # return the rotated image
    return im

# resize the image
def resize_image(im, w, h):
    # resize the image
    im = im.resize((w, h))
    # return the resized image
    return im



# test
if __name__ == '__main__':
    # get the screen shot
    im = get_shot_cut(0, 0, 800, 600)
    # show the screen shot
    im.show()
    # get the active window size
    active_window_size = get_active_window_size()
    # show the active window size
    print(active_window_size)
    # get the region by mouse click and drag
    region = get_region_by_mouse_click_and_drag(0, 0, active_window_size[0], active_window_size[1])
    # show the region
    region.show()