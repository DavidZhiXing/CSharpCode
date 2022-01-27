public static class QrCode{
    // create a qr code with the given text
    public static Bitmap Create(string text, int size, ErrorCorrectionLevel errorCorrectionLevel) {
        QrCodeEncodingOptions options = new QrCodeEncodingOptions();
        options.CharacterSet = "UTF-8";
        options.Height = size;
        options.Width = size;
        options.Margin = 1;
        options.ErrorCorrection = errorCorrectionLevel;
        return QrCodeEncoder.Encode(text, options);
    }

    class QrCodeEncodingOptions{
        public string CharacterSet { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Margin { get; set; }
        public ErrorCorrectionLevel ErrorCorrection { get; set; }
    }

    class QrCodeEncoder{
        public static Bitmap Encode(string textForEncoding, QrCodeEncodingOptions options) {
            var qrCodeWriter = new QrCode.QRCodeWriter();
            var encodingOptions = new QrCode.QRCodeEncodingOptions();
            encodingOptions.CharacterSet = options.CharacterSet;
            encodingOptions.Height = options.Height;
            encodingOptions.Width = options.Width;
            encodingOptions.Margin = options.Margin;
            encodingOptions.ErrorCorrection = options.ErrorCorrection;
            return qrCodeWriter.Encode(textForEncoding, encodingOptions);
        }
    }

    class QrCodeDecoder{
        public static string Decode(Bitmap bitmap){
            var reader = new QrCode.QRCodeReader();
            var result = reader.Decode(bitmap);
            return result.Text;
        }
    }


    public class QRCodeWriter{
        public Bitmap Encode(string textForEncoding, QRCodeEncodingOptions options){
            return null;
        }
    }

    public class QRCodeEncodingOptions{
        public string CharacterSet { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Margin { get; set; }
        public ErrorCorrectionLevel ErrorCorrection { get; set; }
    }

    public enum ErrorCorrectionLevel{
        L,
        M,
        Q,
        H
    }

}