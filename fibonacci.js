function fibonacci(n) {
  let fib = [0, 1];
  for (let i = 2; i <= n; i++) {
    fib.push(fib[i - 1] + fib[i - 2]);
  }
  return fib.slice(0, n);
}

let n = parseInt(prompt("Enter the number of terms: "));
console.log("The Fibonacci sequence up to " + n + " terms is:");
console.log(fibonacci(n));
