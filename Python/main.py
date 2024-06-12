import numpy as np
import matplotlib.pyplot as plt

# Угловые диапазоны
theta1 = np.linspace(np.pi, 3*np.pi/2, 400)
theta2 = np.linspace(3*np.pi/2, 2*np.pi, 400)

# Радиусные функции
r1 = -2 * np.sin(theta1)
r2 = -np.sin(theta2)

# Полярный график
plt.figure(figsize=(8, 8))
ax = plt.subplot(111, projection='polar')

# Построение функций в полярных координатах
ax.plot(theta1, r1, label=r'$r = -2\sin\theta$')
ax.plot(theta2, r2, label=r'$r = -\sin\theta$')

# Заполнение области
ax.fill_between(theta1, 0, r1, color='lightgrey', alpha=0.5)
ax.fill_between(theta2, 0, r2, color='lightgrey', alpha=0.5)

# Настройка графика
ax.set_rmax(3)
ax.set_rticks([1, 2, 3])
ax.set_rlabel_position(-22.5)
ax.grid(True)
ax.legend(loc='upper right')

plt.show()