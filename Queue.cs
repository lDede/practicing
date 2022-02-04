using System;
using System.Windows.Forms;

public class Queue
{
	private Cell firstCell;
	private Cell lastCell;
	private int quantity;
	
	public Queue()	{
		firstCell = new Cell(null,null);
		lastCell = firstCell;
		quantity = 0;
	}

	public bool isEmpty() {
		return lastCell == firstCell;
    }

	public void Enqueue(Cell newCell) {
			lastCell.SetNext(newCell);
			lastCell.SetValue(newCell.GetValue());
			lastCell = lastCell.GetNext();
		quantity++;
	}

	public Object Dequeue() {
		Cell cell = firstCell;
		if(firstCell != lastCell) {
			firstCell = firstCell.GetNext();
			quantity--;
		}
		return cell.GetValue();
    }

	public Object Peek() {
		if(!isEmpty())
			return this.firstCell.GetValue();
		else
			return 0;
    }
}
