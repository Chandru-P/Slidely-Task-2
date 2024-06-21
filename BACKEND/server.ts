import express, { Request, Response } from 'express';
import * as fs from 'fs';

const app = express();
app.use(express.json());

const DB_FILE = 'db.json';

app.get('/ping', (req: Request, res: Response) => {
  res.send('True');
});

app.post('/submit', (req: Request, res: Response) => {
  const { name, email, phone, github_link, stopwatch_time } = req.body;

  let submissions: any[] = [];
  try {
    const data = fs.readFileSync(DB_FILE, 'utf-8');
    submissions = JSON.parse(data);
  } catch (err) {
    console.error(err);
  }

  submissions.push({ name, email, phone, github_link, stopwatch_time });

  fs.writeFileSync(DB_FILE, JSON.stringify(submissions, null, 2));

  res.sendStatus(200);
});


app.get('/read', (req: Request, res: Response) => {
  const { index } = req.query;
  let submissions: any[] = [];
  try {
    const data = fs.readFileSync(DB_FILE, 'utf-8');
    submissions = JSON.parse(data);
  } catch (err) {
    console.error(err);
  }

  const submission = submissions[parseInt(index as string)];
  if (submission) {
    res.json(submission);
  } else {
    res.status(404).send('Submission not found');
  }
});

const PORT = 5000;
app.listen(PORT, () => {
  console.log(`Server running on port ${PORT}`);
});
