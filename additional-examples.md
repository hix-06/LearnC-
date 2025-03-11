# Additional Examples Using Straight Forward Expansion Method

## Example 3: Oscillator with Mixed Nonlinear Terms (x·ẋ)

Consider the equation:
$$\ddot{x} + \omega_0^2 x + \varepsilon x\dot{x} = F_0\cos(\Omega t)$$

This includes a mixed nonlinear term (x·ẋ) which is common in systems with nonlinear damping.

### Step 1: Expand the solution as a power series in ε
$$x(t) = x_0(t) + \varepsilon x_1(t) + \varepsilon^2 x_2(t) + ...$$

### Step 2: Substitute the expansion into the original equation
$$\ddot{x}_0 + \varepsilon \ddot{x}_1 + ... + \omega_0^2(x_0 + \varepsilon x_1 + ...) + \varepsilon(x_0 + \varepsilon x_1 + ...)(\dot{x}_0 + \varepsilon \dot{x}_1 + ...) = F_0\cos(\Omega t)$$

### Step 3: Expand the nonlinear term
$$x\dot{x} = (x_0 + \varepsilon x_1 + ...)(\dot{x}_0 + \varepsilon \dot{x}_1 + ...) = x_0\dot{x}_0 + \varepsilon(x_0\dot{x}_1 + x_1\dot{x}_0) + O(\varepsilon^2)$$

### Step 4: Collect terms by powers of ε
$$(\ddot{x}_0 + \omega_0^2 x_0 - F_0\cos(\Omega t)) + \varepsilon(\ddot{x}_1 + \omega_0^2 x_1 + x_0\dot{x}_0) + O(\varepsilon^2) = 0$$

### Step 5: Set each coefficient of ε^n to zero

**Order ε^0 equation:**
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0\cos(\Omega t)$$

**Order ε^1 equation:**
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0\dot{x}_0$$

### Step 6: Solve the order ε^0 equation

This is a standard forced harmonic oscillator with solution:
$$x_0(t) = A\cos(\omega_0 t) + B\sin(\omega_0 t) + \frac{F_0\cos(\Omega t)}{\omega_0^2 - \Omega^2}$$

For simplicity, we'll use initial conditions $x(0) = 0$ and $\dot{x}(0) = 0$.

From $x_0(0) = 0$:
$$A + \frac{F_0}{\omega_0^2 - \Omega^2} = 0 \implies A = -\frac{F_0}{\omega_0^2 - \Omega^2}$$

From $\dot{x}_0(0) = 0$:
$$-\omega_0 A + \omega_0 B - \frac{\Omega F_0\sin(0)}{\omega_0^2 - \Omega^2} = 0 \implies B = \frac{\omega_0 F_0}{\omega_0(\omega_0^2 - \Omega^2)} = \frac{F_0}{\omega_0^2 - \Omega^2}$$

Therefore:
$$x_0(t) = -\frac{F_0}{\omega_0^2 - \Omega^2}\cos(\omega_0 t) + \frac{F_0}{\omega_0^2 - \Omega^2}\sin(\omega_0 t) + \frac{F_0\cos(\Omega t)}{\omega_0^2 - \Omega^2}$$

Let $D = \frac{F_0}{\omega_0^2 - \Omega^2}$ for brevity:
$$x_0(t) = -D\cos(\omega_0 t) + D\sin(\omega_0 t) + D\cos(\Omega t)$$

### Step 7: Compute $\dot{x}_0(t)$
$$\dot{x}_0(t) = D\omega_0\sin(\omega_0 t) + D\omega_0\cos(\omega_0 t) - D\Omega\sin(\Omega t)$$

### Step 8: Calculate $x_0(t)\dot{x}_0(t)$ for the order ε^1 equation
$$x_0(t)\dot{x}_0(t) = [-D\cos(\omega_0 t) + D\sin(\omega_0 t) + D\cos(\Omega t)][D\omega_0\sin(\omega_0 t) + D\omega_0\cos(\omega_0 t) - D\Omega\sin(\Omega t)]$$

Expanding this product gives:
$$x_0(t)\dot{x}_0(t) = D^2\omega_0[-\cos(\omega_0 t)\sin(\omega_0 t) - \cos^2(\omega_0 t) + \sin^2(\omega_0 t) + \sin(\omega_0 t)\cos(\omega_0 t)] + D^2\Omega[\cos(\omega_0 t)\sin(\Omega t) - \sin(\omega_0 t)\sin(\Omega t) - \cos(\Omega t)\sin(\Omega t)]$$

Using trigonometric identities:
- $\sin(a)\cos(a) = \frac{\sin(2a)}{2}$
- $\cos^2(a) = \frac{1+\cos(2a)}{2}$
- $\sin^2(a) = \frac{1-\cos(2a)}{2}$
- $\sin(a)\sin(b) = \frac{\cos(a-b)-\cos(a+b)}{2}$
- $\cos(a)\sin(b) = \frac{\sin(a+b)-\sin(a-b)}{2}$

After extensive algebraic manipulation, we get:
$$x_0(t)\dot{x}_0(t) = D^2\omega_0 + D^2\omega_0\sin(2\omega_0 t) + D^2\Omega\text{[Combination of sines and cosines with frequencies }(\omega_0 \pm \Omega)\text{ and }2\Omega\text{]}$$

### Step 9: Solve the order ε^1 equation
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0\dot{x}_0$$

The particular solution contains terms with frequencies $0$ (constant), $2\omega_0$, $(\omega_0 + \Omega)$, $(\omega_0 - \Omega)$, and $2\Omega$. For each term with frequency $\alpha$, the solution has the form $\frac{c}{\omega_0^2-\alpha^2}\cos(\alpha t)$ or $\frac{c}{\omega_0^2-\alpha^2}\sin(\alpha t)$ where $c$ is the coefficient.

For the constant term $-D^2\omega_0$, the particular solution is $-\frac{D^2\omega_0}{\omega_0^2} = -\frac{D^2}{\omega_0}$.

For terms with frequency $2\omega_0$, $\omega_0 + \Omega$, $\omega_0 - \Omega$, and $2\Omega$, the solutions follow the pattern described above.

The complete solution for $x_1(t)$ is a sum of these particular solutions and the homogeneous solution $C\cos(\omega_0 t) + E\sin(\omega_0 t)$ where $C$ and $E$ are constants determined by initial conditions.

### Step 10: Final approximate solution
$$x(t) = x_0(t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

This gives us the approximate solution to order $\varepsilon$.

## Example 4: Oscillator with Rational Nonlinearity

Consider the equation:
$$\ddot{x} + \omega_0^2 x + \varepsilon\frac{1}{1+x^2} = F_0\sin(\Omega t)$$

This includes a rational nonlinearity which appears in certain mechanical and electrical systems.

### Step 1: Expand the solution as a power series in ε
$$x(t) = x_0(t) + \varepsilon x_1(t) + \varepsilon^2 x_2(t) + ...$$

### Step 2: Substitute the expansion into the original equation
$$\ddot{x}_0 + \varepsilon \ddot{x}_1 + ... + \omega_0^2(x_0 + \varepsilon x_1 + ...) + \varepsilon\frac{1}{1+(x_0 + \varepsilon x_1 + ...)^2} = F_0\sin(\Omega t)$$

### Step 3: Expand the rational nonlinear term
For the term $\frac{1}{1+x^2}$, we use the binomial series expansion:
$$\frac{1}{1+x^2} = 1 - x^2 + x^4 - x^6 + ... \text{ for } |x^2| < 1$$

Substituting our series expansion:
$$\frac{1}{1+(x_0 + \varepsilon x_1 + ...)^2} = 1 - (x_0 + \varepsilon x_1 + ...)^2 + O(x^4)$$

Further expanding:
$$\frac{1}{1+(x_0 + \varepsilon x_1 + ...)^2} = 1 - x_0^2 - 2\varepsilon x_0 x_1 + O(\varepsilon^2) + O(x^4)$$

### Step 4: Collect terms by powers of ε
$$(\ddot{x}_0 + \omega_0^2 x_0 - F_0\sin(\Omega t)) + \varepsilon(\ddot{x}_1 + \omega_0^2 x_1 + 1 - x_0^2) + O(\varepsilon^2) = 0$$

### Step 5: Set each coefficient of ε^n to zero

**Order ε^0 equation:**
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0\sin(\Omega t)$$

**Order ε^1 equation:**
$$\ddot{x}_1 + \omega_0^2 x_1 = -1 + x_0^2$$

### Step 6: Solve the order ε^0 equation

This is a standard forced harmonic oscillator with solution:
$$x_0(t) = A\cos(\omega_0 t) + B\sin(\omega_0 t) + \frac{F_0\sin(\Omega t)}{\omega_0^2 - \Omega^2}$$

Using initial conditions $x(0) = 0$ and $\dot{x}(0) = 0$:

From $x_0(0) = 0$:
$$A + 0 = 0 \implies A = 0$$

From $\dot{x}_0(0) = 0$:
$$\omega_0 B + \frac{\Omega F_0\cos(0)}{\omega_0^2 - \Omega^2} = 0 \implies B = -\frac{\Omega F_0}{\omega_0(\omega_0^2 - \Omega^2)}$$

Therefore:
$$x_0(t) = -\frac{\Omega F_0}{\omega_0(\omega_0^2 - \Omega^2)}\sin(\omega_0 t) + \frac{F_0\sin(\Omega t)}{\omega_0^2 - \Omega^2}$$

Let $G = \frac{F_0}{\omega_0^2 - \Omega^2}$ for brevity:
$$x_0(t) = -\frac{\Omega G}{\omega_0}\sin(\omega_0 t) + G\sin(\Omega t)$$

### Step 7: Calculate $x_0^2(t)$ for the order ε^1 equation
$$x_0^2(t) = \left[-\frac{\Omega G}{\omega_0}\sin(\omega_0 t) + G\sin(\Omega t)\right]^2$$

Expanding:
$$x_0^2(t) = \frac{\Omega^2 G^2}{\omega_0^2}\sin^2(\omega_0 t) - 2\frac{\Omega G^2}{\omega_0}\sin(\omega_0 t)\sin(\Omega t) + G^2\sin^2(\Omega t)$$

Using trigonometric identities:
$$\sin^2(a) = \frac{1-\cos(2a)}{2}$$
$$\sin(a)\sin(b) = \frac{\cos(a-b)-\cos(a+b)}{2}$$

We get:
$$x_0^2(t) = \frac{\Omega^2 G^2}{2\omega_0^2}[1-\cos(2\omega_0 t)] - \frac{\Omega G^2}{\omega_0}[\cos(\omega_0-\Omega)t - \cos(\omega_0+\Omega)t] + \frac{G^2}{2}[1-\cos(2\Omega t)]$$

Rearranging:
$$x_0^2(t) = \left(\frac{\Omega^2 G^2}{2\omega_0^2} + \frac{G^2}{2}\right) - \frac{\Omega^2 G^2}{2\omega_0^2}\cos(2\omega_0 t) - \frac{\Omega G^2}{\omega_0}\cos(\omega_0-\Omega)t + \frac{\Omega G^2}{\omega_0}\cos(\omega_0+\Omega)t - \frac{G^2}{2}\cos(2\Omega t)$$

### Step 8: Solve the order ε^1 equation
$$\ddot{x}_1 + \omega_0^2 x_1 = -1 + x_0^2$$

Substituting our expression for $x_0^2(t)$:
$$\ddot{x}_1 + \omega_0^2 x_1 = -1 + \left(\frac{\Omega^2 G^2}{2\omega_0^2} + \frac{G^2}{2}\right) - \frac{\Omega^2 G^2}{2\omega_0^2}\cos(2\omega_0 t) - \frac{\Omega G^2}{\omega_0}\cos(\omega_0-\Omega)t + \frac{\Omega G^2}{\omega_0}\cos(\omega_0+\Omega)t - \frac{G^2}{2}\cos(2\Omega t)$$

Let $K = -1 + \left(\frac{\Omega^2 G^2}{2\omega_0^2} + \frac{G^2}{2}\right)$ for the constant term.

The particular solution for $x_1(t)$ has the form:
$$x_1(t) = \frac{K}{\omega_0^2} + \frac{-\frac{\Omega^2 G^2}{2\omega_0^2}}{\omega_0^2-(2\omega_0)^2}\cos(2\omega_0 t) + \frac{-\frac{\Omega G^2}{\omega_0}}{\omega_0^2-(\omega_0-\Omega)^2}\cos(\omega_0-\Omega)t + \frac{\frac{\Omega G^2}{\omega_0}}{\omega_0^2-(\omega_0+\Omega)^2}\cos(\omega_0+\Omega)t + \frac{-\frac{G^2}{2}}{\omega_0^2-(2\Omega)^2}\cos(2\Omega t)$$

Simplifying:
$$x_1(t) = \frac{K}{\omega_0^2} + \frac{\Omega^2 G^2}{6\omega_0^4}\cos(2\omega_0 t) - \frac{\Omega G^2}{\omega_0[\omega_0^2-(\omega_0-\Omega)^2]}\cos(\omega_0-\Omega)t + \frac{\Omega G^2}{\omega_0[\omega_0^2-(\omega_0+\Omega)^2]}\cos(\omega_0+\Omega)t - \frac{G^2}{2[\omega_0^2-(2\Omega)^2]}\cos(2\Omega t)$$

This is the particular solution. We also need to add the homogeneous solution $C\cos(\omega_0 t) + E\sin(\omega_0 t)$ with constants $C$ and $E$ determined by the initial conditions that $x_1(0) = 0$ and $\dot{x}_1(0) = 0$.

### Step 9: Final approximate solution
$$x(t) = x_0(t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Substituting our results:
$$x(t) = -\frac{\Omega G}{\omega_0}\sin(\omega_0 t) + G\sin(\Omega t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

This gives us the approximate solution to order $\varepsilon$ for the oscillator with rational nonlinearity.
