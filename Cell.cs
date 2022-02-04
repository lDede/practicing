using System;

public class Cell
{
	private Cell next;
	private Object value;

	public Cell(Cell nextCell, Object newValue)	{
		this.next = nextCell;
		this.value = newValue;
	}
	public void SetValue(Object newValue) { this.value = newValue; }
	public Object GetValue() { return this.value; }
	public void SetNext(Cell nextCell) { this.next = nextCell; } 
	public Cell GetNext() { return this.next; }
}
