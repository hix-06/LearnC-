# Straight Forward Expansion Method - Detailed Solutions

## Example 1: Forced Oscillator with Cubic Nonlinearity

Consider the forced Duffing equation:

$$\ddot{x} + \omega_0^2 x + \varepsilon x^3 = F_0 \cos(\Omega t)$$

### Step 1: Expand the solution as a power series in ε

$$x(t) = x_0(t) + \varepsilon x_1(t) + \varepsilon^2 x_2(t) + ...$$

### Step 2: Substitute the expansion into the original equation

$$\ddot{x}_0 + \varepsilon \ddot{x}_1 + \varepsilon^2 \ddot{x}_2 + ... + \omega_0^2(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...) + \varepsilon(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...)^3 = F_0 \cos(\Omega t)$$

### Step 3: Expand the cubic term
$$(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...)^3 = x_0^3 + 3x_0^2(\varepsilon x_1) + 3x_0(\varepsilon x_1)^2 + (\varepsilon x_1)^3 + ... = x_0^3 + 3\varepsilon x_0^2 x_1 + O(\varepsilon^2)$$

### Step 4: Collect terms by powers of ε

$$(\ddot{x}_0 + \omega_0^2 x_0 - F_0 \cos(\Omega t)) + \varepsilon(\ddot{x}_1 + \omega_0^2 x_1 + x_0^3) + O(\varepsilon^2) = 0$$

### Step 5: Set each coefficient of ε^n to zero

**Order ε^0 equation:**
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0 \cos(\Omega t)$$

**Order ε^1 equation:**
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^3$$

### Step 6: Solve the order ε^0 equation

This is a standard forced harmonic oscillator. The general solution consists of the homogeneous solution plus the particular solution:

$$x_0(t) = A \cos(\omega_0 t) + B \sin(\omega_0 t) + \frac{F_0 \cos(\Omega t)}{\omega_0^2 - \Omega^2}$$

Where A and B are constants determined by initial conditions. For simplicity, let's assume the system starts from rest at the origin: $x(0) = 0$ and $\dot{x}(0) = 0$.

Applying these conditions:
$$x_0(0) = A + \frac{F_0}{\omega_0^2 - \Omega^2} = 0 \implies A = -\frac{F_0}{\omega_0^2 - \Omega^2}$$

$$\dot{x}_0(0) = -\omega_0 A \sin(\omega_0 \cdot 0) + \omega_0 B \cos(\omega_0 \cdot 0) - \frac{\Omega F_0 \sin(\Omega \cdot 0)}{\omega_0^2 - \Omega^2} = 0 \implies B = 0$$

Therefore:
$$x_0(t) = -\frac{F_0}{\omega_0^2 - \Omega^2} \cos(\omega_0 t) + \frac{F_0}{\omega_0^2 - \Omega^2} \cos(\Omega t) = \frac{F_0}{\omega_0^2 - \Omega^2}[\cos(\Omega t) - \cos(\omega_0 t)]$$

Let's denote $\frac{F_0}{\omega_0^2 - \Omega^2} = C$ for brevity:
$$x_0(t) = C[\cos(\Omega t) - \cos(\omega_0 t)]$$

### Step 7: Solve the order ε^1 equation

Now we substitute $x_0(t)$ into the equation for $x_1(t)$:

$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^3 = -C^3[\cos(\Omega t) - \cos(\omega_0 t)]^3$$

To expand this cubic term, we use the binomial expansion:
$$[\cos(\Omega t) - \cos(\omega_0 t)]^3 = [\cos(\Omega t)]^3 - 3[\cos(\Omega t)]^2[\cos(\omega_0 t)] + 3[\cos(\Omega t)][\cos(\omega_0 t)]^2 - [\cos(\omega_0 t)]^3$$

Using the trigonometric identities:
$$\cos^3(\theta) = \frac{3\cos(\theta) + \cos(3\theta)}{4}$$
$$\cos^2(\theta_1)\cos(\theta_2) = \frac{\cos(2\theta_1 + \theta_2) + \cos(2\theta_1 - \theta_2) + 2\cos(\theta_2)}{4}$$

After extensive algebraic manipulation and combining terms, we get:

$$\ddot{x}_1 + \omega_0^2 x_1 = -C^3[a_1\cos(\omega_0 t) + a_2\cos(3\omega_0 t) + a_3\cos(\Omega t) + a_4\cos(3\Omega t) + a_5\cos(2\omega_0 + \Omega)t + a_6\cos(2\omega_0 - \Omega)t + a_7\cos(2\Omega + \omega_0)t + a_8\cos(2\Omega - \omega_0)t]$$

Where $a_1$ through $a_8$ are constants resulting from the expansion.

For brevity, I'll solve for the particular solution of $x_1(t)$ considering just a few representative terms. The solution has the form:

$$x_1(t) = \sum_{i} \frac{-C^3 a_i \cos(\alpha_i t)}{\omega_0^2 - \alpha_i^2}$$

Where $\alpha_i$ represents each of the frequencies in the forcing function except when $\alpha_i = \omega_0$ (which would cause division by zero). For the term with $\alpha_i = \omega_0$, the particular solution takes the form:

$$\frac{-C^3 a_1 t \sin(\omega_0 t)}{2\omega_0}$$

This term is secular (grows unbounded with time), indicating a limitation of the method for this particular case.

### Step 8: Final approximate solution
$$x(t) = x_0(t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Substituting our results:
$$x(t) = C[\cos(\Omega t) - \cos(\omega_0 t)] + \varepsilon x_1(t) + O(\varepsilon^2)$$

Where $x_1(t)$ is the solution found in Step 7.

## Example 2: Oscillator with Quadratic Nonlinearity and Forcing

Consider the differential equation:
$$\ddot{x} + \omega_0^2 x + \varepsilon x^2 = F_0 \sin(\Omega t)$$

### Step 1: Expand the solution as a power series in ε
$$x(t) = x_0(t) + \varepsilon x_1(t) + \varepsilon^2 x_2(t) + ...$$

### Step 2: Substitute the expansion into the original equation
$$\ddot{x}_0 + \varepsilon \ddot{x}_1 + \varepsilon^2 \ddot{x}_2 + ... + \omega_0^2(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...) + \varepsilon(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...)^2 = F_0 \sin(\Omega t)$$

### Step 3: Expand the quadratic term
$$(x_0 + \varepsilon x_1 + \varepsilon^2 x_2 + ...)^2 = x_0^2 + 2x_0(\varepsilon x_1) + (\varepsilon x_1)^2 + ... = x_0^2 + 2\varepsilon x_0 x_1 + O(\varepsilon^2)$$

### Step 4: Collect terms by powers of ε
$$(\ddot{x}_0 + \omega_0^2 x_0 - F_0 \sin(\Omega t)) + \varepsilon(\ddot{x}_1 + \omega_0^2 x_1 + x_0^2) + O(\varepsilon^2) = 0$$

### Step 5: Set each coefficient of ε^n to zero

**Order ε^0 equation:**
$$\ddot{x}_0 + \omega_0^2 x_0 = F_0 \sin(\Omega t)$$

**Order ε^1 equation:**
$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^2$$

### Step 6: Solve the order ε^0 equation

This is a standard forced harmonic oscillator. The general solution is:

$$x_0(t) = A \cos(\omega_0 t) + B \sin(\omega_0 t) + \frac{F_0 \sin(\Omega t)}{\omega_0^2 - \Omega^2}$$

For simplicity, let's assume initial conditions $x(0) = 0$ and $\dot{x}(0) = 0$.

Applying these conditions:
$$x_0(0) = A + 0 = 0 \implies A = 0$$

$$\dot{x}_0(0) = \omega_0 B + \frac{\Omega F_0}{\omega_0^2 - \Omega^2} = 0 \implies B = -\frac{\Omega F_0}{\omega_0(\omega_0^2 - \Omega^2)}$$

Therefore:
$$x_0(t) = -\frac{\Omega F_0}{\omega_0(\omega_0^2 - \Omega^2)} \sin(\omega_0 t) + \frac{F_0}{\omega_0^2 - \Omega^2} \sin(\Omega t)$$

Let's denote $\frac{F_0}{\omega_0^2 - \Omega^2} = D$ for brevity:
$$x_0(t) = -\frac{\Omega D}{\omega_0} \sin(\omega_0 t) + D \sin(\Omega t)$$

### Step 7: Solve the order ε^1 equation

Now we substitute $x_0(t)$ into the equation for $x_1(t)$:

$$\ddot{x}_1 + \omega_0^2 x_1 = -x_0^2 = -\left(-\frac{\Omega D}{\omega_0} \sin(\omega_0 t) + D \sin(\Omega t)\right)^2$$

Expanding this quadratic term:
$$x_0^2 = \frac{\Omega^2 D^2}{\omega_0^2} \sin^2(\omega_0 t) - 2\frac{\Omega D^2}{\omega_0} \sin(\omega_0 t)\sin(\Omega t) + D^2 \sin^2(\Omega t)$$

Using the trigonometric identities:
$$\sin^2(\theta) = \frac{1 - \cos(2\theta)}{2}$$
$$\sin(\theta_1)\sin(\theta_2) = \frac{\cos(\theta_1 - \theta_2) - \cos(\theta_1 + \theta_2)}{2}$$

We get:
$$x_0^2 = \frac{\Omega^2 D^2}{2\omega_0^2}[1 - \cos(2\omega_0 t)] - \frac{\Omega D^2}{\omega_0}[\cos(\omega_0 t - \Omega t) - \cos(\omega_0 t + \Omega t)] + \frac{D^2}{2}[1 - \cos(2\Omega t)]$$

Rearranging:
$$x_0^2 = \frac{\Omega^2 D^2}{2\omega_0^2} + \frac{D^2}{2} - \frac{\Omega^2 D^2}{2\omega_0^2}\cos(2\omega_0 t) - \frac{\Omega D^2}{\omega_0}\cos(\omega_0 t - \Omega t) + \frac{\Omega D^2}{\omega_0}\cos(\omega_0 t + \Omega t) - \frac{D^2}{2}\cos(2\Omega t)$$

Now the equation for $x_1(t)$ becomes:
$$\ddot{x}_1 + \omega_0^2 x_1 = -\frac{\Omega^2 D^2}{2\omega_0^2} - \frac{D^2}{2} + \frac{\Omega^2 D^2}{2\omega_0^2}\cos(2\omega_0 t) + \frac{\Omega D^2}{\omega_0}\cos(\omega_0 t - \Omega t) - \frac{\Omega D^2}{\omega_0}\cos(\omega_0 t + \Omega t) + \frac{D^2}{2}\cos(2\Omega t)$$

The particular solution for $x_1(t)$ has the form:
$$x_1(t) = \frac{1}{\omega_0^2}\left(-\frac{\Omega^2 D^2}{2\omega_0^2} - \frac{D^2}{2}\right) + \frac{\frac{\Omega^2 D^2}{2\omega_0^2}}{\omega_0^2 - 4\omega_0^2}\cos(2\omega_0 t) + \frac{\frac{\Omega D^2}{\omega_0}}{\omega_0^2 - (\omega_0 - \Omega)^2}\cos(\omega_0 t - \Omega t) - \frac{\frac{\Omega D^2}{\omega_0}}{\omega_0^2 - (\omega_0 + \Omega)^2}\cos(\omega_0 t + \Omega t) + \frac{\frac{D^2}{2}}{\omega_0^2 - 4\Omega^2}\cos(2\Omega t)$$

Simplifying:
$$x_1(t) = -\frac{D^2}{2\omega_0^2}\left(\frac{\Omega^2}{\omega_0^2} + 1\right) - \frac{\Omega^2 D^2}{6\omega_0^4}\cos(2\omega_0 t) + \frac{\Omega D^2}{\omega_0(\omega_0^2 - (\omega_0 - \Omega)^2)}\cos(\omega_0 t - \Omega t) - \frac{\Omega D^2}{\omega_0(\omega_0^2 - (\omega_0 + \Omega)^2)}\cos(\omega_0 t + \Omega t) + \frac{D^2}{2(\omega_0^2 - 4\Omega^2)}\cos(2\Omega t)$$

Note: When $\omega_0 = 2\Omega$, we would have a resonance case that would require special handling.

### Step 8: Final approximate solution
$$x(t) = x_0(t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Substituting our results:
$$x(t) = -\frac{\Omega D}{\omega_0} \sin(\omega_0 t) + D \sin(\Omega t) + \varepsilon x_1(t) + O(\varepsilon^2)$$

Where $x_1(t)$ is the solution found in Step 7.
