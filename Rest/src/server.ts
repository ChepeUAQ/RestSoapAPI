import app from './app';
import connectDB from './config/mongo';

const PORT = process.env.PORT || 3000;

connectDB().then(() => {
    app.listen(PORT, () => {
        console.log(`Server running on port ${PORT}`);
    });
}).catch((err: any) => {
    console.error('Error connecting to MongoDB', err);
});
