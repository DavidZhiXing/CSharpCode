# import Image
from PIL import Image

# ascii draw a dog

def draw_dog():
    print("  ____")
    print(" /    \\" )
    print("/      \\" )
    print("\\      /")
    print(" \\____/")

# convert an image to ascii
def convert_image(image_path):
    # open image
    image = Image.open(image_path)
    # convert to ascii
    image = image.convert("L")
    # resize image
    image = image.resize((500, 500))
    # convert to ascii
    image = image.convert("L")
    # get image width and height
    width, height = image.size
    # create a new image
    new_image = Image.new("L", (width, height))
    # loop through each pixel
    for x in range(width):
        for y in range(height):
            # get pixel
            pixel = image.getpixel((x, y))
            # get pixel value
            pixel_value = int(pixel)
            # set pixel value
            new_image.putpixel((x, y), pixel_value)
    # return new image
    return new_image


# convert gif to ascii gif
def convert_gif(gif_path):
    # open gif
    gif = Image.open(gif_path)
    # get gif width and height
    width, height = gif.size
    # create a new gif
    new_gif = Image.new("L", (width, height))
    # loop through each frame
    for frame in range(0, gif.n_frames):
        # get frame
        gif.seek(frame)
        # convert frame to ascii
        frame = gif.convert("L")
        # resize frame
        frame = frame.resize((500, 500))
        # convert frame to ascii
        frame = frame.convert("L")
        # loop through each pixel
        for x in range(width):
            for y in range(height):
                # get pixel
                pixel = frame.getpixel((x, y))
                # get pixel value
                pixel_value = int(pixel)
                # set pixel value
                new_gif.putpixel((x, y), pixel_value)
    # return new gif
    return new_gif

# test
if __name__ == "__main__":
    # get image path
    image_path = "dog.jpg"
    # convert image
    image = convert_image(image_path)
    # draw image
    image.show()
    # draw dog
    draw_dog()
