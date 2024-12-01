import app from './app';
import connectDB from './config/mongo';

const PORT = process.env.PORT || 3000;

connectDB();

