for(int i=1; i<=n; i++)
write("hola mundo");
  private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int f1, f2, c1, c2;
            f1 = 0; f2 = 0; c2 = 0; c1=0;
            x1.RetDim(ref f1, ref c1);
            x2.RetDim(ref f2, ref c2);
            if ((f1 == f2) && (c1 == c2))
                x1.Sumar(x2, ref x3);
            else
                textBox7.Text = "no es posible,RETIRA NOMAJ CHOCO";
        }

        private void restarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int f1, f2, c1, c2;
            f1 = 0; f2 = 0; c2 = 0; c1 = 0;
            x1.RetDim(ref f1, ref c1);
            x2.RetDim(ref f2, ref c2);
            if ((f1 == f2) && (c1 == c2))
                x1.Restar(x2, ref x3);
            else
                textBox7.Text = "i am sorry cocho, no es posible la resta, cambiate a turismo!!!!!!";
