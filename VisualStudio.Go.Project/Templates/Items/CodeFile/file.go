package main

import "fmt"

func main() {
	fmt.Printf("Hello, world.\n")
	fmt.Printf("Type an integer.\n")
	var i int
	fmt.Scan(&i)
	fmt.Println("read number", i, "from stdin")
}